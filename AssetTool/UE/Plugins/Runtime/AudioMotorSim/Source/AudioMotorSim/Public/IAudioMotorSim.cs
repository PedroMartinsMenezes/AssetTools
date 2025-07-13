namespace AssetTool
{
    [JsonAsset("AudioMotorSimComponent")]
    public class UAudioMotorSimComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}