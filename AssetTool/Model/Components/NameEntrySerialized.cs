using AssetTool.Model.Basic;
using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("Offset: 406. Size: Dynamic")]
    public class FNameEntrySerialized
    {
        public FString Name = string.Empty;

        public UInt16[] DummyHashes = new UInt16[] { 0, 0 };
    }
}
