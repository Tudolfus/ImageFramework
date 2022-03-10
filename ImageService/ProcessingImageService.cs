using Models.Images;
using Models.Plugins;
using Newtonsoft.Json;

namespace ImageService
{
    public class ProcessingImageService
    {
        public async Task<PluginJsonList?> GetPluginsList()
        {
            try
            {
                using StreamReader r = new(Path.Combine(Environment.CurrentDirectory, "plugins.json"));
                string json = await r.ReadToEndAsync();
                var list = JsonConvert.DeserializeObject<PluginJsonList>(json);
                list.Plugins = list?.Plugins?.Where(x => x.IsActive == true).ToList();

                return list;
            }
            catch (Exception ex)
            {
                //logger
                return new PluginJsonList();
            }
        }
         
        public async Task ProcessingImages(List<ProcessImageRequestModel> processImages)
        {
            foreach (var processImage in processImages)
            {
                foreach (var plugin in processImage?.Plugins)
                {
                    switch (plugin.Id)
                    {
                        case PluginIdEnum.Increase:
                            {
                                break;
                            }
                        case PluginIdEnum.Decrease:
                            {
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
        }
    }
}