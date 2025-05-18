namespace AssetTool
{
    [JsonAsset("TestPhaseComponent")]
    public class UTestPhaseComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}