namespace AssetTool
{
    [JsonAsset("ObjectMixerObjectFilter")]
    public class UObjectMixerObjectFilter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ObjectMixerBlueprintObjectFilter")]
    public class UObjectMixerBlueprintObjectFilter : UObjectMixerObjectFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}