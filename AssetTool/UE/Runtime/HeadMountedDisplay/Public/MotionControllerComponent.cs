namespace AssetTool
{
    [JsonAsset("MotionControllerComponent")]
    public class UMotionControllerComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}