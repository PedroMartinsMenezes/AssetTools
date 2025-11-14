namespace AssetTool
{
    [JsonAsset("ComponentElementObjectInterface")]
    public class UComponentElementObjectInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}