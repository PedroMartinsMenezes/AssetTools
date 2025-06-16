namespace AssetTool
{
    [JsonAsset("ActorFactoryBoxVolume")]
    public class UActorFactoryBoxVolume : UActorFactoryVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}