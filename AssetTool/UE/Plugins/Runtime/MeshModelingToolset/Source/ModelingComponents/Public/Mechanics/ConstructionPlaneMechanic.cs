namespace AssetTool
{
    [JsonAsset("ConstructionPlaneMechanic")]
    public class UConstructionPlaneMechanic : UInteractionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}