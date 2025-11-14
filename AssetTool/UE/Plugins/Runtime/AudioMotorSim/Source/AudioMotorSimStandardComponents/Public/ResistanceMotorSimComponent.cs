namespace AssetTool
{
    [JsonAsset("ResistanceMotorSimComponent")]
    public class UResistanceMotorSimComponent : UAudioMotorSimComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}