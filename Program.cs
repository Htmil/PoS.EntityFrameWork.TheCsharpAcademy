using PoS.EntityFrameWork.TheCsharpAcademy;
using Spectre.Console;


var isAppRunning = true; // 3

while (isAppRunning)
{
    var options = AnsiConsole.Prompt
    (
        new SelectionPrompt<MenuOptions>()
        .Title("What would you like to do?")
        .AddChoices(
            MenuOptions.AddProduct,
            MenuOptions.DeleteProduct,
            MenuOptions.UpdateProduct,
            MenuOptions.ViewProduct,
            MenuOptions.ViewAllProducts,
            MenuOptions.Quit
        )
    );

    switch (options)
    {
        case MenuOptions.AddProduct:
            ProductService.InsertProduct();
            break;
        case MenuOptions.DeleteProduct:
            ProductService.DeleteProduct();
            break;
        case MenuOptions.UpdateProduct:
            ProductService.UpdateProduct();
            break;
        case MenuOptions.ViewProduct:
            ProductService.GetProduct();
            break;
        case MenuOptions.ViewAllProducts:
            ProductService.GetProducts();
            break;
        case MenuOptions.Quit:
            ProductController.Quit();
            break;
    }
}
// #


enum MenuOptions // 1
{
    AddProduct,
    DeleteProduct,
    UpdateProduct,
    ViewProduct,
    ViewAllProducts,
    Quit
}
// #