namespace AssetTool.Generator.CodeGen
{
    public static class NodeExtensions
    {
        private static Dictionary<string, Func<UK2Node, AssetPackage, string>> MemberNames = [];

        public static List<Node> GetFlowNodes(this List<Node> nodes)
        {
            return nodes.Where(x => x.InputPins.Exists(y => y.IsExec()) || x.OutputPins.Exists(y => y.IsExec())).ToList();
        }

        public static List<Node> GetDataNodes(this List<Node> nodes)
        {
            return nodes.Where(x => x.InputPins.All(y => !y.IsExec()) && x.OutputPins.All(y => !y.IsExec())).ToList();
        }

        public static List<Node> GetInitialNodes(this List<Node> nodes)
        {
            return nodes.Where(x => x.InputPins.All(y => !y.IsExec()) && x.OutputPins.Any(y => y.IsExec())).ToList();
        }

        public static string GetMemberName(string className, UK2Node baseNode, AssetPackage package)
        {
            if (MemberNames.TryGetValue(className, out var func))
            {
                string name = func(baseNode, package);
                name = name.StartsWith("K2_") ? name.Substring(3) : name;
                return name;
            }
            else
            {
                return null;
            }
        }

        static NodeExtensions()
        {
            MemberNames.Add("K2Node_AssignDelegate", (node, package) => ((UK2Node_AssignDelegate)node).GetMemberString("DelegateReference", "name 'MemberName'"));
            MemberNames.Add("K2Node_CallArrayFunction", (node, package) => ((UK2Node_CallArrayFunction)node).GetMemberString("FunctionReference", "name 'MemberName'"));
            MemberNames.Add("K2Node_CallFunction", (node, package) => ((UK2Node_CallFunction)node).GetMemberString("FunctionReference", "name 'MemberName'"));
            MemberNames.Add("K2Node_CustomEvent", (node, package) => ((UK2Node_CustomEvent)node).GetMemberString("name 'CustomFunctionName'"));
            MemberNames.Add("K2Node_Event", (node, package) => ((UK2Node_Event)node).GetMemberString("EventReference", "name 'MemberName'"));
            MemberNames.Add("K2Node_IfThenElse", (node, package) => "Branch");
            MemberNames.Add("K2Node_Knot", (node, package) => "Knot");
            MemberNames.Add("K2Node_MacroInstance", (node, package) => package.GetTypeNameFromPackageIndex(int.Parse(((UK2Node_MacroInstance)node).GetMemberString("MacroGraphReference", "obj 'MacroGraph'"))));
            MemberNames.Add("K2Node_Timeline", (node, package) => ((UK2Node_Timeline)node).GetMemberString("name 'TimelineName'"));
            MemberNames.Add("K2Node_VariableGet", (node, package) => ((UK2Node_VariableGet)node).GetMemberString("VariableReference", "name 'MemberName'"));
            MemberNames.Add("K2Node_VariableSet", (node, package) => ((UK2Node_VariableSet)node).GetMemberString("VariableReference", "name 'MemberName'"));
            MemberNames.Add("K2Node_PromotableOperator", (node, package) => ((UK2Node_PromotableOperator)node).GetMemberString("FunctionReference", "name 'MemberName'"));
        }
    }
}
