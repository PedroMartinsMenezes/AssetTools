namespace AssetTool
{
    [JsonAsset("AudioMotorModelComponent")]
    public class UAudioMotorModelComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}