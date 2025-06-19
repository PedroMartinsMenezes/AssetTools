namespace AssetTool
{
    [JsonAsset("Selection")]
    public class USelection : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}