namespace AssetTool
{
    [JsonAsset("AControlRigControlActor")]
    public class AControlRigControlActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}