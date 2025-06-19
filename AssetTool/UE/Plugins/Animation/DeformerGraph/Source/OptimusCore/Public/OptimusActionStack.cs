namespace AssetTool
{
    [JsonAsset("OptimusActionStack")]
    public class UOptimusActionStack : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}