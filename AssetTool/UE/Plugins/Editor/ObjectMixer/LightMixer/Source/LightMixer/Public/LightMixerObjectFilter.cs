namespace AssetTool
{
    [JsonAsset("LightMixerObjectFilter")]
    public class ULightMixerObjectFilter : UObjectMixerObjectFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}