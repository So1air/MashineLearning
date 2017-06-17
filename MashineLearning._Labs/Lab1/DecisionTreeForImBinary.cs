using System;
using System.Collections.Generic;

namespace MashineLearning.Classification
{
    class DecisionTreeForImBinary: ClassificatorForImBinary
    {
        public enum MethodBuild
        {
            CART,
            C4_5
        }
        public struct InfoOfComponentTree
        {
            public readonly string Content;
            public readonly uint Depth;
            public InfoOfComponentTree(string cnt, uint dpt)
            {
                Content = cnt;
                Depth = dpt;
            }
        }

        private abstract class ComponentTree
        {
            public abstract string Classificate(ImBinary im);
        }

        private class Leaf: ComponentTree
        {
            private string _type;

            public override string Classificate(ImBinary im)
            {
                return _type;
            }

            public Leaf(string t)
            {
                _type = t;
            }
        }

        private class Decision: ComponentTree
        {
            private ComponentTree _solution0;
            private ComponentTree _solution1;
            private uint _number_prop;

            public override string Classificate(ImBinary im)
            {
                if (im.GetProp(_number_prop) == 0)
                    return _solution0.Classificate(im);
                else
                    return _solution1.Classificate(im);
            }

            public Decision(uint num_pr, ComponentTree s0, ComponentTree s1)
            {
                _number_prop = num_pr;
                _solution0 = s0;
                _solution1 = s1;
            }
        }

        private ComponentTree _mainTree;
        private List<uint> _numbersImportantProps = new List<uint>();
        //private List<uint> _depths = new List<uint>();
        private List<InfoOfComponentTree> _infoOfTree = new List<InfoOfComponentTree>();

        
        public readonly MethodBuild MethodBuildTree;// { public get; protected set; } 

        public uint[] NumbersImportantProps
        {
            get { return _numbersImportantProps.ToArray(); }
        }

        public InfoOfComponentTree[] InfoOfTree
        {
            get { return _infoOfTree.ToArray(); }
        }

        public string GetInfoStringAboutTree()
        {
            string result = _infoOfTree[0].Content;            
            for (int i = 1, n = _infoOfTree.Count; i < n; i++)
            {
                result += "\n";
                for(uint j = 0, dpt = _infoOfTree[i].Depth; j < dpt; j++, result += " ");
                result += _infoOfTree[i].Depth.ToString() + ":";
                result += _infoOfTree[i].Content;
            }
            return result;
        }

        public override string Classificate(ImBinary im)
        {
            if ((im != null) && (this._heightIm == im.RowCount) && (this._widthIm == im.ColumnCount))
                return _mainTree.Classificate(im);
            else
                return null;
        }

        private ComponentTree BuildTree(LearnSetOfImBinarys learn_dataSet, List<uint> numbersImpProps, uint curr_depth)
        {
            if (learn_dataSet.Types.Length == 1)
            {
                _infoOfTree.Add(new InfoOfComponentTree(learn_dataSet.Types[0], curr_depth)); 
                return new Leaf(learn_dataSet.Types[0]);
            }

            if (numbersImpProps.Count == 1)
            {                
                _numbersImportantProps.Add(numbersImpProps[0]);                    
                _infoOfTree.Add(new InfoOfComponentTree(numbersImpProps[0].ToString(), curr_depth++));
                if (learn_dataSet.ImBinarys[0].GetProp(numbersImpProps[0]) == 0)
                {
                    _infoOfTree.Add(new InfoOfComponentTree(learn_dataSet.Types[0], curr_depth));
                    _infoOfTree.Add(new InfoOfComponentTree(learn_dataSet.Types[1], curr_depth));
                    return new Decision(numbersImpProps[0], new Leaf(learn_dataSet.Types[0]), new Leaf(learn_dataSet.Types[1]));
                }
                else
                {
                    _infoOfTree.Add(new InfoOfComponentTree(learn_dataSet.Types[1], curr_depth));
                    _infoOfTree.Add(new InfoOfComponentTree(learn_dataSet.Types[0], curr_depth));
                    return new Decision(numbersImpProps[0], new Leaf(learn_dataSet.Types[1]), new Leaf(learn_dataSet.Types[0]));
                }
            }

            ImBinary[] allIm = learn_dataSet.ImBinarys;
            bool notImportantProp;
            for (int indCheckProp = 0; indCheckProp < numbersImpProps.Count;)
            {
                notImportantProp = true;
                for (int i = 1, countIm = allIm.Length; notImportantProp && (i < countIm); i++)
                    notImportantProp = allIm[0].GetProp(numbersImpProps[indCheckProp]) == allIm[i].GetProp(numbersImpProps[indCheckProp]);
                if (notImportantProp)
                    numbersImpProps.RemoveAt(indCheckProp);
                else
                    indCheckProp++;
            }

            uint greatImportantProp = numbersImpProps[0];            
            LearnSetOfImBinarys[] nextSplitSet = learn_dataSet.Split(numbersImpProps[0]);            
            LearnSetOfImBinarys s0 = nextSplitSet[0], 
                                s1 = nextSplitSet[1];
            switch (this.MethodBuildTree)
            {
                case MethodBuild.CART:
                    #region CART
                    double minGini = GiniSplit(nextSplitSet[0], nextSplitSet[1]),
                           tmpGini;
                    for (int i = 1; i < numbersImpProps.Count; i++)
                    {
                        nextSplitSet = learn_dataSet.Split(numbersImpProps[i]);
                        if ((tmpGini = GiniSplit(nextSplitSet[0], nextSplitSet[1])) < minGini)
                        {
                            minGini = tmpGini;
                            greatImportantProp = numbersImpProps[i];
                            s0 = nextSplitSet[0];
                            s1 = nextSplitSet[1];
                        }
                    }
                    #endregion
                    break;
                case MethodBuild.C4_5:
                    #region C4.5
                    double maxGainModify = GainModify(learn_dataSet, nextSplitSet[0], nextSplitSet[1]),
                           tmpGainModify;
                    for (int i = 1; i < numbersImpProps.Count; i++)
                    {
                        nextSplitSet = learn_dataSet.Split(numbersImpProps[i]);
                        if ((tmpGainModify = GainModify(learn_dataSet, nextSplitSet[0], nextSplitSet[1])) > maxGainModify)
                        {
                            maxGainModify = tmpGainModify;
                            greatImportantProp = numbersImpProps[i];
                            s0 = nextSplitSet[0];
                            s1 = nextSplitSet[1];
                        }
                    }
                    #endregion
                    break;
                default:
                    break;
            }
            _numbersImportantProps.Add(greatImportantProp);
            numbersImpProps.Remove(greatImportantProp);
            _infoOfTree.Add(new InfoOfComponentTree(greatImportantProp.ToString(), curr_depth));
            return new Decision(greatImportantProp, BuildTree(s0, numbersImpProps.GetRange(0, numbersImpProps.Count), ++curr_depth), BuildTree(s1, numbersImpProps.GetRange(0, numbersImpProps.Count), curr_depth));
        }
        
        #region CART
        public static double Gini(LearnSetOfImBinarys U)
        {
            double summ = 0;
            string[] types = U.Types;
            foreach (string t in types)
                summ += Math.Pow(U.GetFrequencyType(t), 2);
            return 1 - summ;
        }

        public static double GiniSplit(LearnSetOfImBinarys U_left, LearnSetOfImBinarys U_right)
        {
            int N = U_left.Count + U_right.Count;
            return (U_left.Count * Gini(U_left) / N) + (U_right.Count * Gini(U_right) / N);
        }
        #endregion

        #region C4.5
        public static double Gain(LearnSetOfImBinarys U, LearnSetOfImBinarys U_left, LearnSetOfImBinarys U_right)
        {
            return Info(U) - (InfoAboutSplitProp(U_left, U_right) / U.Count);
        }        

        private static double Info(LearnSetOfImBinarys U)
        {
            string[] types = U.Types;
            double summ = 0;
            foreach (string type in types)
                summ += U.GetFrequencyType(type) * Math.Log(U.GetFrequencyType(type), 2);
            return -summ;
        }

        private static double InfoAboutSplitProp(LearnSetOfImBinarys U_left, LearnSetOfImBinarys U_right)
        {
            return U_left.Count * Info(U_left) + U_right.Count * Info(U_right);
        }

        public static double GainModify(LearnSetOfImBinarys U, LearnSetOfImBinarys U_left, LearnSetOfImBinarys U_right)
        {
            return Gain(U, U_left, U_right) / Split(U, U_left, U_right);
        }

        private static double Split(LearnSetOfImBinarys U, LearnSetOfImBinarys U_left, LearnSetOfImBinarys U_right)
        {
            return -((U_left.Count / U.Count) * Math.Log(U_left.Count / U.Count, 2) + (U_right.Count / U.Count) * Math.Log(U_right.Count / U.Count, 2));
        }
        #endregion

        public static DecisionTreeForImBinary CreateInstance(ImBinary[] learn_data, MethodBuild mBuildTree = MethodBuild.CART)
        {
            LearnSetOfImBinarys learn_dataSet = new LearnSetOfImBinarys(learn_data);
            if (learn_dataSet.Count == learn_data.Length)                     //при выполнении этого условия все данные корректны
                return new DecisionTreeForImBinary(learn_dataSet, mBuildTree);
            else
                return null;
        }

        private DecisionTreeForImBinary(LearnSetOfImBinarys learn_dataSet, MethodBuild mBuildTree = MethodBuild.CART)
            :base(learn_dataSet.HeightIm, learn_dataSet.WidthIm)
        {
            List<uint> numbersImpProps = new List<uint>();
            for(uint i = 0, count_props =  (uint)(learn_dataSet.HeightIm * learn_dataSet.WidthIm); i < count_props; i++)
                numbersImpProps.Add(i);
            this.MethodBuildTree = mBuildTree;
            _mainTree = BuildTree(learn_dataSet, numbersImpProps, 0);
        }
    }
}
