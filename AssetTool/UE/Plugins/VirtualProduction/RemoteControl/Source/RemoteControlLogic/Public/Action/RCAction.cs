namespace AssetTool
{
    [JsonAsset("RCAction")]
    public class URCAction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}