namespace AssetTool
{
    [JsonAsset("OptimusNode")]
    public class UOptimusNode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}