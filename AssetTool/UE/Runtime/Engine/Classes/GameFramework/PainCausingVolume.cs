namespace AssetTool
{
    [JsonAsset("PainCausingVolume")]
    public class APainCausingVolume : APhysicsVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}