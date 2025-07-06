namespace AssetTool
{
    [JsonAsset("MotionControllerComponent")]
    public class UMotionControllerComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}