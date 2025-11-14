namespace AssetTool
{
    [JsonAsset("LearningAgentsObservationSchema")]
    public class ULearningAgentsObservationSchema : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LearningAgentsObservationObject")]
    public class ULearningAgentsObservationObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LearningAgentsObservations")]
    public class ULearningAgentsObservations : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}