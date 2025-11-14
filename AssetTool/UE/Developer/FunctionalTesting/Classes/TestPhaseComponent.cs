namespace AssetTool
{
    [JsonAsset("TestPhaseComponent")]
    public class UTestPhaseComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}