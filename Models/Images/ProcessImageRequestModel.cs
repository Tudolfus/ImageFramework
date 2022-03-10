using Models.Plugins;
using System.Drawing;

namespace Models.Images
{
    public class ProcessImageRequestModel
    {
        public Image? Image { get; set; }

        public List<BasePlugin>? Plugins { get; set; }
    }
}
