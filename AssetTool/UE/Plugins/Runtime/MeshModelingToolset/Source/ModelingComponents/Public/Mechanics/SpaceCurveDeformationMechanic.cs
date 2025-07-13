namespace AssetTool
{
    [JsonAsset("SpaceCurveDeformationMechanicPropertySet")]
    public class USpaceCurveDeformationMechanicPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SpaceCurveDeformationMechanic")]
    public class USpaceCurveDeformationMechanic : UInteractionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}