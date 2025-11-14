namespace AssetTool
{
    [JsonAsset("InterchangeStaticMeshActorFactory")]
    public class UInterchangeStaticMeshActorFactory : UInterchangeActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}