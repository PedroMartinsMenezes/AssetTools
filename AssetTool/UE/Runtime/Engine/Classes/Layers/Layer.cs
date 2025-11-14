namespace AssetTool
{
    [JsonAsset("Layer")]
    public class ULayer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}