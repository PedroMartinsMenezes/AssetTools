namespace AssetTool
{
    [JsonAsset("ActorFactoryBoxVolume")]
    public class UActorFactoryBoxVolume : UActorFactoryVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}