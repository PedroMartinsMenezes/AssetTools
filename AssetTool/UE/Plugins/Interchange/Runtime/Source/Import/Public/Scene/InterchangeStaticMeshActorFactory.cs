namespace AssetTool
{
    [JsonAsset("InterchangeStaticMeshActorFactory")]
    public class UInterchangeStaticMeshActorFactory : UInterchangeActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}