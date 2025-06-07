namespace AssetTool
{
    [JsonAsset("InterchangeStaticMeshActorFactory")]
    public class UInterchangeStaticMeshActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}