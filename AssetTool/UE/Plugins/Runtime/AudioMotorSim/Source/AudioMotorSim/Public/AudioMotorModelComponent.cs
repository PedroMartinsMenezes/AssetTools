namespace AssetTool
{
    [JsonAsset("AudioMotorModelComponent")]
    public class UAudioMotorModelComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}