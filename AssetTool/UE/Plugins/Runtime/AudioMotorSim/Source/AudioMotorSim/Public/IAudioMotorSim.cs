namespace AssetTool
{
    [JsonAsset("AudioMotorSimComponent")]
    public class UAudioMotorSimComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}