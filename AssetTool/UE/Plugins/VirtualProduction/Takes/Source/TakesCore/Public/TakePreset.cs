namespace AssetTool
{
    [JsonAsset("TakePreset")]
    public class UTakePreset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}