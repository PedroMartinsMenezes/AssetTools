namespace AssetTool
{
    [JsonAsset("CodeProjectItem")]
    public class UCodeProjectItem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}