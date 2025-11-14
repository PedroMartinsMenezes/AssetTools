namespace AssetTool
{
    [JsonAsset("TakePreset")]
    public class UTakePreset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}