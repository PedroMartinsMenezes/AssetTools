namespace AssetTool
{
    [TransferibleStruct("NiagaraDataInterfaceGPUParamInfo")]
    public class FNiagaraDataInterfaceGPUParamInfo : ITransferible
    {
        public FString DataInterfaceHLSLSymbol;
        public FString DIClassName;
        public List<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions;

        [Location("bool FNiagaraDataInterfaceGPUParamInfo::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DataInterfaceHLSLSymbol);

            transfer.Move(ref DIClassName);

            if (Supports.AddGeneratedFunctionsToGPUParamInfo)
            {
                transfer.Move(ref GeneratedFunctions);
            }

            return this;
        }
    }

    public class FNiagaraDataInterfaceGeneratedFunction : ITransferible
    {
        public FName DefinitionName;
        public FString InstanceName;
        public List<TTuple<FName, FName>> Specifiers;
        public List<FNiagaraVariableCommonReference> VariadicInputs;
        public List<FNiagaraVariableCommonReference> VariadicOutputs;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DefinitionName);
            transfer.Move(ref InstanceName);
            transfer.Move(ref Specifiers);

            if (Supports.AddVariadicParametersToGPUFunctionInfo)
            {
                transfer.Move(ref VariadicInputs);
                transfer.Move(ref VariadicOutputs);
            }

            return this;
        }
    }

    public class FNiagaraShaderScript : ITransferible
    {
        public FBool bCooked;
        public Int32 NumPermutations;
        public FNiagaraCompileHash BaseCompileHash;

        [Location("void FNiagaraShaderScript::SerializeShaderMap(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            transfer.Move(ref NumPermutations);

            return this;
        }
    }
}