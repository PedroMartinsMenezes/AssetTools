namespace AssetTool
{
    [JsonAsset("ObjectMixerObjectFilter")]
    public class UObjectMixerObjectFilter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ObjectMixerBlueprintObjectFilter")]
    public class UObjectMixerBlueprintObjectFilter : UObjectMixerObjectFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}