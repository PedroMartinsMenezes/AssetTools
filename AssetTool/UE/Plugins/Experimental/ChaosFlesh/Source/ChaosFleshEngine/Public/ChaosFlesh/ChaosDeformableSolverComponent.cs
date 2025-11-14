namespace AssetTool
{
    [JsonAsset("DeformableSolverComponent")]
    public class UDeformableSolverComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}