namespace AssetTool
{
    [JsonAsset("PainCausingVolume")]
    public class APainCausingVolume : APhysicsVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}