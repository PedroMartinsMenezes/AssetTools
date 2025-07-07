namespace AssetTool
{
    [JsonAsset("DMXMVRSceneActorFactory")]
    public class UDMXMVRSceneActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}