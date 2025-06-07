namespace AssetTool
{
    [JsonAsset("InterchangeCineCameraActorFactory")]
    public class UInterchangeCineCameraActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeCameraActorFactory")]
    public class UInterchangeCameraActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}