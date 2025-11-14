namespace AssetTool
{
    [JsonAsset("PCGGraphFactory")]
    public class UPCGGraphFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGraphInstanceFactory")]
    public class UPCGGraphInstanceFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}