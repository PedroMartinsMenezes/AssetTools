namespace AssetTool
{
    [JsonAsset("CalibrationPointComponent")]
    public class UCalibrationPointComponent : UProceduralMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}