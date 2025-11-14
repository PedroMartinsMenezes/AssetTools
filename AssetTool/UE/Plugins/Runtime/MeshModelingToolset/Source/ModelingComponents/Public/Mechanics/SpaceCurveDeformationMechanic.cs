namespace AssetTool
{
    [JsonAsset("SpaceCurveDeformationMechanicPropertySet")]
    public class USpaceCurveDeformationMechanicPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SpaceCurveDeformationMechanic")]
    public class USpaceCurveDeformationMechanic : UInteractionMechanic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}