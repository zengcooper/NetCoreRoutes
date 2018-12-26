url：
~~~
https://localhost:44351/
~~~

### 路径参数的路由  
~~~
routes.MapRoute(
        name: "TutorialPathValueRoute",
        template: "{controller}/{action}/{name}/{age?}"
    );
~~~
适配URL
* /tutorial/welcome/ken/20  
* /tutorial/welcome/ken  
* /tutorial/welcome/ken?age=20  


### 固定前后缀的路由 
前缀路由配置
~~~
routes.MapRoute(
    name: "TutorialPrefixRoute",
    template: "jiaocheng/{action}",
    defaults: new { controller = "Tutorial" }
);
~~~
* /jiaocheng/index  
* /jiaocheng/welcome  

后缀路由配置
~~~
routes.MapRoute(
    name: "TutorialSuffixRoute",
    template: "{controller}/{action}.html"
);
~~~
* /tutorial/index.html 
* /tutorial/welcome.html 
* /home/index.html 
* /home/time.html 

### 路由参数长度范围约束  
路由配置:约束name长度不能>5，age<150
~~~
routes.MapRoute(
                    name: "TutorialLengthRoute",
                    template: "hello/{name}/{age?}",
                    defaults: new { controller = "Tutorial", action = "Welcome", name = "ken" },
                    constraints: new
                    {
                        name = new MaxLengthRouteConstraint(5),
                        age = new CompositeRouteConstraint(new IRouteConstraint[] {
                                            new IntRouteConstraint(),
                                            new MinRouteConstraint(1),
                                            new MaxRouteConstraint(150) })
                    }
                );
~~~
此路由适配  
* /hello  
* /hello/ken  
* /hello/ken/100  
次路由不适配  
* /hello/kenaaaa  
* /hello/ken/1000  
同等路由：
~~~
routes.MapRoute(
                    name: "TutorialLengthRoute2",
                    template: "hello2/{name:length(1,5)}/{age:range(1,150)?}",
                    defaults: new { controller = "Tutorial", action = "Welcome", name = "ken" }
                );
~~~

### 正则表达式约束的路由
~~~
routes.MapRoute(
           name: "TutorialRegexRoute",
                template: "welcome/{name}",
                defaults: new { controller = "Tutorial", action = "Welcome" },
                constraints: new { name = @"k[a-z]*" }
            );
~~~
此路由适配：
* /welcome/k 
* /welcome/ken 
* /welcome/kevin  
路由不适配:
* /welcome/k1
* /welcome/keN
* /welcome/tom

### 自定义路由约束
约束当name长度>5时，name中不能包含,
~~~
    public class NameRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            string name = values["name"]?.ToString();
            if (name == null) return true;
            if (name.Length > 5 && name.Contains(",")) return false;
            return true;
        }
    }
~~~
ConfigureServices
~~~
//引入自定义路由约束
        services.Configure<RouteOptions>(options =>
        {
            options.ConstraintMap.Add("name", typeof(NameRouteConstraint));
        });
~~~
路由配置
~~~
routes.MapRoute(
    name: "TutorialDiyConstraintRoute",
    template: "diy/{name}",
    defaults: new { controller = "Tutorial", action = "Welcome" },
    constraints: new { name = new NameRouteConstraint() }
);
~~~
路由适配
* /diy/ken
* */diy/ken,* 自定义筛选
* /diy/kenny

路由不适配
 *  */diy/kenny,*

### MVC 绑定式路由配置
#### 默认路由配置
Controller/Action
~~~
//配置默认路由
     routes.MapRoute(
          name: "Default",
          template: "{controller}/{action}",
          defaults: new { controller = "Home", action = "Index" }
     );
~~~
#### 绑定式路由配置
~~~
        [Route("")]
        [Route("/test/home")]
        public IActionResult Index()
        {
            return Content("ASP.NET Core RouteAttribute test by cooper from cooper.io");
        }

        [Route("servertime")]
        [Route("/t/t")]
        public IActionResult Time(){
            return Content($"ServerTime：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - cooper.io");
        }


        [Route("welcome/{name:name}")]
        public IActionResult Welcome(string name){
            return Content($"Welcome {name} !");
        }
~~~
适应地址  
* /test/welcome/abc
* /test/servertime
* /t/t
* /test/home

配置项|说明
--- |---
[Route("/test")] |	表示该Controller访问路由前缀为/test，必须以/开头
[Route("")]|表示以Controller的路由配置为前缀访问该Action；可以通过/test路由到该Action
[Route("/test/home")] |	表示忽略Controller的路由配置；可以通过/test/home路由到该Action
[Route("servertime")] |	表示以Controller的路由配置为前缀访问该Action；可以通过/test/servertime路由到该Action|
[Route("/t/t")] |	表示忽略Controller的路由配置；可以通过/t/t路由到该Action|

RouteAttribute中配置的参数，就相当于我们集中式配置中的路由模板(template),最终框架还是帮我们初始化成路由规则，以[Route("/test/home")]为例，相当于生成了以下路由配置

~~~
routes.MapRoute(
    name: "Default",
    template: "test/home",
    defaults: new { controller = "Test", action = "Index" }
);
~~~