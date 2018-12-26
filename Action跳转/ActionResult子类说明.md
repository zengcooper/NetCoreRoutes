ActionResult子类说明

| Action返回类型        | Controller内置方法                   | 说明                                                         |
| --------------------- | ------------------------------------ | ------------------------------------------------------------ |
| ViewResult            | View()                               | 将视图数据交由Razor视图引擎渲染                              |
| PartialViewResult     | PartialView()                        | 将视图数据交由Razor视图引擎部分视图（PartialView）渲染       |
| ContentResult         | Content()                            | 返回自定义文本                                               |
| JsonResult            | Json()                               | 返回对象的JSON序列化结果                                     |
| FileResult            | File()                               | 返回要写入响应中的二进制输出                                 |
| RedirectResult        | Redirect()                           | 重定向到指定的Url                                            |
| RedirectToRouteResult | RedirectToAction(),RedirectToRoute() | 重定向到指定的Action或者路由                                 |
| EmptyResult           | /                                    | 在Action返回null或者Action定义返回关键字是void时会被包装为EmptyResult |

参考URL：
*  https://localhost:44351/pmt/GetId/123
*  https://localhost:44351/pmt/GetArray/abc