namespace AssetTool
{
    [JsonAsset("OptimusResourceDescription")]
    public class UOptimusResourceDescription : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}