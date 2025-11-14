namespace AssetTool
{
    [JsonAsset("ActorFactoryBoxVolume")]
    public class UActorFactoryBoxVolume : UActorFactoryVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}