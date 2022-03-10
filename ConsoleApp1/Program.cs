// S
using ImageService;
using Models.Images;
using Models.Plugins;
using Models.Plugins.PluginOptions;
using System.Drawing;

Console.WriteLine("Hello, World!");

ProcessingImageService processingImageService = new ProcessingImageService();

var pluginList = await processingImageService.GetPluginsList();

//foreach (var plugin in pluginList?.Plugins)
//{
//    Console.WriteLine(plugin.Name);
//}

Image testImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "cat.jpg"));

var testProcessingList = new List<ProcessImageRequestModel>()
{
    new ProcessImageRequestModel()
    {
        Image = testImage,
        Plugins = new List<BasePlugin>()
        {
            new IncreasePlugin()
            {
                Value = 1
            }
        }
    }
};

await processingImageService.ProcessingImages(testProcessingList);

