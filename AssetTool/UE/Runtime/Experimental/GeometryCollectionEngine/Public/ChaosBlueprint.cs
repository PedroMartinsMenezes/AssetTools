namespace AssetTool
{
    [JsonAsset("ChaosDestructionListener")]
    public class UChaosDestructionListener : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}