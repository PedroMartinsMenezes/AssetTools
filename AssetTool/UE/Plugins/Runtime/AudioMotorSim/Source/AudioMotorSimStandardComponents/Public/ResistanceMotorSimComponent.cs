namespace AssetTool
{
    [JsonAsset("ResistanceMotorSimComponent")]
    public class UResistanceMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}