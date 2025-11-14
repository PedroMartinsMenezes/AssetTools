namespace AssetTool
{
    [JsonAsset("MotorSimOutputMotoSynth")]
    public class UMotorSimOutputMotoSynth : USynthComponentMoto
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}