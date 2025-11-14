namespace AssetTool
{
    [JsonAsset("ChaosDestructionListener")]
    public class UChaosDestructionListener : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}