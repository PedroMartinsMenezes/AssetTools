namespace AssetTool
{
    [JsonAsset("CalibrationPointComponent")]
    public class UCalibrationPointComponent : UProceduralMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}