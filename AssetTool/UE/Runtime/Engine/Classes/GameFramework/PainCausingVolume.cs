namespace AssetTool
{
    [JsonAsset("PainCausingVolume")]
    public class APainCausingVolume : APhysicsVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}