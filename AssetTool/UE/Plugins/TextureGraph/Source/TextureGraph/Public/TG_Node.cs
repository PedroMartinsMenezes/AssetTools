namespace AssetTool
{
    [JsonAsset("TG_Node")]
    public class UTG_Node : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}