namespace AssetTool
{
    [JsonAsset("MetaHumanConfig")]
    public class UMetaHumanConfig : UObject
    {
        public FByteBulkData SolverTemplateDataCipherText;
        public FByteBulkData SolverConfigDataCipherText;
        public FByteBulkData SolverDefinitionsCipherText;
        public FByteBulkData SolverHierarchicalDefinitionsCipherText;
        public FByteBulkData SolverPCAFromDNACipherText;
        public FByteBulkData FittingTemplateDataCipherText;
        public FByteBulkData FittingConfigDataCipherText;
        public FByteBulkData FittingConfigTeethDataCipherText;
        public FByteBulkData FittingIdentityModelDataCipherText;
        public FByteBulkData FittingControlsDataCipherText;
        public FByteBulkData PredictiveGlobalTeethTrainingData;
        public FByteBulkData PredictiveTrainingData;

        [Location("void UMetaHumanConfig::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref SolverTemplateDataCipherText);
            transfer.Move(ref SolverConfigDataCipherText);
            transfer.Move(ref SolverDefinitionsCipherText);
            transfer.Move(ref SolverHierarchicalDefinitionsCipherText);
            transfer.Move(ref SolverPCAFromDNACipherText);
            transfer.Move(ref FittingTemplateDataCipherText);
            transfer.Move(ref FittingConfigDataCipherText);
            transfer.Move(ref FittingConfigTeethDataCipherText);
            transfer.Move(ref FittingIdentityModelDataCipherText);
            transfer.Move(ref FittingControlsDataCipherText);
            transfer.Move(ref PredictiveGlobalTeethTrainingData);
            transfer.Move(ref PredictiveTrainingData);

            return this;
        }
    }
}