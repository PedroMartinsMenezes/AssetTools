namespace AssetTool
{
    [JsonAsset("OptimusActionStack")]
    public class UOptimusActionStack : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}