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

- ViewData
  - 派生自 ViewDataDictionary，因此它有可用的字典属性，如 ContainsKey、Add、Remove 和 Clear。
  - 字典中的键是字符串，因此允许有空格。 示例：ViewData[“ken”]
  - 任何非 string 类型均须在视图中进行强制转换才能使用 ViewData。
- ViewBag
  - 派生自 DynamicViewData，因此它可使用点表示法 ([@ViewBag](https://github.com/ViewBag).SomeKey = ) 创建动态属性，且无需强制转换。
  - ViewBag 的语法使添加到控制器和视图的速度更快。
  - ViewBag 更易于检查 NULL 值。 示例：[@ViewBag](https://github.com/ViewBag).Person?.Name



参考URL：

*  https://localhost:44351/pmt/GetId/123
*  https://localhost:44351/pmt/GetArray/abc