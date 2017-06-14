using System;
using System.Collections.Generic;
using System.Linq;

namespace MashineLearning.Classification
{
    class CollectionOfImBinarys 
    {
        private Random accidentFactor = new Random();
        public double MAX_POWER_NOISE = 0.3;

        public enum TypeNoise { Simple }

        private class ModelImWithNoiseIm_s
        {
            public ImBinary M;
            public List<ImBinary> N = new List<ImBinary>();
        }

        private Dictionary<string, Dictionary<string, ModelImWithNoiseIm_s>> _datafetchesImages = new Dictionary<string,Dictionary<string, ModelImWithNoiseIm_s>>();
        private uint _size = 0;

        public uint Size
        {
            get { return _size; }
        }        
        /*         
         возврат коллекций:
         * List<ImBinary> Вернуть весь список();                                                                                     +
         * List<ImBinary> Вернуть список элементов одинаковой разм-ти(byte rc, byte cc);                                             +
         * List<ImBinary> Вернуть список элементов одинакового типа и разм-ти(byte rc, byte cc, string type);                        +
         * List<ImBinary> Вернуть список элементов одинакового типа(string type);                                                    +
         * List<ImBinary> Вернуть список эталонов(byte rc, byte cc);                                                                 +
         * List<ImBinary> Вернуть список эталонов(string type);                                                                      +
         * List<ImBinary> Вернуть массив зашумлённых изображений(byte rc, byte cc, string type);                                     +
         * string[]       Вернуть массив размерностей();                                                                             +
         * string[]       Вернуть массив типов(byte rc, byte cc);                                                                    +
         * string[]       Вернуть массив типов с размерностями();                                                                    +

         возврат элементов:
         * ImBinary Вернуть элемент по глобальному индексу(uint);                                                                    +
         * ImBinary Вернуть эталон(byte rc, byte cc, string type);                                                                   +
         * ImBinary Вернуть зашумлённое изображение(byte rc, byte cc, string type, uint index);                                      +
         
         свойства:
         * uint Размер;                                                                                                              +
         * uint Количество размерностей;
         * uint Количество типов(byte rc, byte cc);
         
         информационные:
         * bool Наличие типа(byte rc, byte cc, string type);                                                                         +
         * bool Наличие размерности(byte rc, byte cc);                                                                               +
         
         добавление:
         * bool Добавить эталон(ImBinary);                                                                                        ?, +
         * bool Добавить зашумлённое изображение(ImBinary);                                                                       ?, +
         
         удаление:
         * bool Удалить тип(byte rc, byte cc, string type);                                                                          +
         * bool Удалить размерность(byte rc, byte cc);                                                                               +

         особые:
         * void Простое зашумление(ImBinary image, double power_noise);                                                              +
         * bool Создать зашумлённое изображение из эталона(byte rc, byte cc, string type, double power_noise, TypeNoise t);          +
         * bool PrimitiveCheckOnConformity(ImBinary image1, ImBinary image2);                                                        +
            
         */

        public List<ImBinary> GetAllImBinary()
        {
            List<ImBinary> result = new List<ImBinary>();

            Dictionary<string, Dictionary<string, ModelImWithNoiseIm_s>>.ValueCollection general_sets_of_same_dimensions = _datafetchesImages.Values;
            Dictionary<string, ModelImWithNoiseIm_s>.ValueCollection sets_of_images_of_same_type;
            foreach (Dictionary<string, ModelImWithNoiseIm_s> gset in general_sets_of_same_dimensions)
            {
                sets_of_images_of_same_type = gset.Values;
                foreach (ModelImWithNoiseIm_s set in sets_of_images_of_same_type)
                {
                    if (set.M != null)
                        result.Add(set.M);
                    
                    result.AddRange(set.N);
                }
            }

            return result;   
        }

        public List<ImBinary> GetImBinarys(byte rc, byte cc)
        {
            List<ImBinary> result = new List<ImBinary>();
            if (_datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString()))
            {
                ModelImWithNoiseIm_s[] gset = _datafetchesImages[rc.ToString() + "x" + cc.ToString()].Values.ToArray<ModelImWithNoiseIm_s>();
                foreach (ModelImWithNoiseIm_s imBinarySameType in gset)
                {
                    if (imBinarySameType.M != null)
                        result.Add(imBinarySameType.M);

                    result.AddRange(imBinarySameType.N);
                }
            }

            return result;
        }

        public List<ImBinary> GetImBinarys(byte rc, byte cc, string type)
        {
            List<ImBinary> result = new List<ImBinary>();
            if (type != null)
            {
                string dimensionality = rc.ToString() + "x" + cc.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(type))
                    {
                        if (_datafetchesImages[dimensionality][type].M != null)
                            result.Add(_datafetchesImages[dimensionality][type].M);

                        result.AddRange(_datafetchesImages[dimensionality][type].N);
                    }
            }
            return result;
        }

        public List<ImBinary> GetImBinarys(string type)
        {
            List<ImBinary> result = new List<ImBinary>();
            if (type != null)
            {
                Dictionary<string, ModelImWithNoiseIm_s>[] gen_sets = _datafetchesImages.Values.ToArray<Dictionary<string, ModelImWithNoiseIm_s>>();
                foreach (Dictionary<string, ModelImWithNoiseIm_s> gset in gen_sets)
                    if (gset.ContainsKey(type))
                    {
                        if (gset[type].M != null)
                            result.Add(gset[type].M);

                        result.AddRange(gset[type].N);
                    }
            }
            return result;
        }

        public List<ImBinary> GetModels(byte rc, byte cc)
        {
            List<ImBinary> result = new List<ImBinary>();
            if (_datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString()))
            {
                ModelImWithNoiseIm_s[] gset = _datafetchesImages[rc.ToString() + "x" + cc.ToString()].Values.ToArray<ModelImWithNoiseIm_s>();
                foreach (ModelImWithNoiseIm_s imBinarySameType in gset)
                    if (imBinarySameType.M != null)
                        result.Add(imBinarySameType.M);
            }

            return result;
        }

        public List<ImBinary> GetModels(string type)
        {
            List<ImBinary> result = new List<ImBinary>();
            if (type != null)
            {
                Dictionary<string, ModelImWithNoiseIm_s>[] gen_sets = _datafetchesImages.Values.ToArray<Dictionary<string, ModelImWithNoiseIm_s>>();
                foreach (Dictionary<string, ModelImWithNoiseIm_s> gset in gen_sets)
                    if (gset.ContainsKey(type))
                        if (gset[type].M != null)
                            result.Add(gset[type].M);
            }
            return result;
        }

        public ImBinary[] GetNoiseImages(byte rc, byte cc, string type)
        {
            if (type != null)
            {
                string dimensionality = rc.ToString() + "x" + cc.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(type))
                        return _datafetchesImages[dimensionality][type].N.ToArray();
            }                

            return null;
        }

        public string[] Dimensions
        {
            get
            {                
                return _datafetchesImages.Keys.ToArray<string>();
            }
        }

        public string[] GetTypes(byte rc, byte cc)
        {
            if (_datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString()))
                return _datafetchesImages[rc.ToString() + "x" + cc.ToString()].Keys.ToArray<string>();
            else 
                return new string[0];
        }

        public string[] TypesWithDimension
        {
            get
            {
                List<string> result = new List<string>();
                string[] dim_s = _datafetchesImages.Keys.ToArray<string>(),
                        types;
                foreach (string dim in dim_s)
                {
                    types = _datafetchesImages[dim].Keys.ToArray<string>();
                    foreach (string type in types)
                        result.Add(dim + "_" + type);
                }

                return result.ToArray();
            }
        }

        public bool ContainsType(byte rc, byte cc, string type)
        {
            if (type != null)
                if (_datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString()))
                    return _datafetchesImages[rc.ToString() + "x" + cc.ToString()].ContainsKey(type);

            return false;
        }

        public bool ContainsDimensionality(byte rc, byte cc)
        {
            return _datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString());
        }

        public ImBinary GetImBinary(uint index_im)
        { 
            int index_search_im = -1;

            Dictionary<string, Dictionary<string, ModelImWithNoiseIm_s>>.ValueCollection general_sets_of_same_dimensions = _datafetchesImages.Values;
            Dictionary<string, ModelImWithNoiseIm_s>.ValueCollection sets_of_images_of_same_type;
            foreach (Dictionary<string, ModelImWithNoiseIm_s> gen_set in general_sets_of_same_dimensions)
            {
                sets_of_images_of_same_type = gen_set.Values;
                foreach (ModelImWithNoiseIm_s set_of_same_type in sets_of_images_of_same_type)
                {
                    if (set_of_same_type.M != null)
                    {
                        index_search_im++;
                        if (index_search_im == index_im)
                            return set_of_same_type.M;
                    }

                    foreach (ImBinary noiseIm in set_of_same_type.N)
                    {
                        index_search_im++;
                        if (index_search_im == index_im)
                            return noiseIm;
                    }
                }
            }

            return null;
        }        

        public ImBinary GetModel(byte rc, byte cc, string type)
        {
            if(type != null)
                if (_datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString()))
                    if (_datafetchesImages[rc.ToString() + "x" + cc.ToString()].ContainsKey(type))
                        return _datafetchesImages[rc.ToString() + "x" + cc.ToString()][type].M;

            return null;
        }

        public ImBinary GetNoiseImage(byte rc, byte cc, string type, uint index)
        {
            if (type != null)
            {
                string dimensionality = rc.ToString() + "x" + cc.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(type))
                        if (index < _datafetchesImages[dimensionality][type].N.Count)
                            return _datafetchesImages[dimensionality][type].N[(int)index];
            }

            return null;
        }

        public bool AddModel(ImBinary model)                                         
        {
            if (model.Type != null)
            {
                string dimensionality = model.RowCount.ToString() + "x" + model.ColumnCount.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(model.Type))
                        if (_datafetchesImages[dimensionality][model.Type].M == null)
                        {
                            bool prevent = true;
                            int i = -1;
                            List<ImBinary> noiseImages = _datafetchesImages[dimensionality][model.Type].N;
                            while ((++i < noiseImages.Count) && prevent)
                                prevent = PrimitiveCheckOnConformity(model, noiseImages[i]);
                            if (prevent)
                                _datafetchesImages[dimensionality][model.Type].M = model;
                            else 
                                return false;
                        }
                        else
                            return false;
                    else _datafetchesImages[dimensionality].Add(model.Type, new ModelImWithNoiseIm_s() { M = model });
                else
                {
                    Dictionary<string, ModelImWithNoiseIm_s> newGen_set = new Dictionary<string, ModelImWithNoiseIm_s>();
                    newGen_set.Add(model.Type, new ModelImWithNoiseIm_s() { M = model });
                    _datafetchesImages.Add(dimensionality, newGen_set);
                }
            }
            else 
                return false;

            _size++;
            return true;
        }

        public int AddNoiseImage(ImBinary noise_image)                              
        {
            int result;
            if (noise_image.Type != null)
            {
                string dimensionality = noise_image.RowCount.ToString() + "x" + noise_image.ColumnCount.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(noise_image.Type))
                        if (_datafetchesImages[dimensionality][noise_image.Type].M != null)
                        {
                            if (PrimitiveCheckOnConformity(noise_image, _datafetchesImages[dimensionality][noise_image.Type].M))
                            {
                                _datafetchesImages[dimensionality][noise_image.Type].N.Add(noise_image);
                                result = _datafetchesImages[dimensionality][noise_image.Type].N.Count - 1;
                            }
                            else
                                return -1;
                        }
                        else
                        {
                            bool prevent = true;
                            int i = -1;
                            List<ImBinary> noiseImages = _datafetchesImages[dimensionality][noise_image.Type].N;
                            while ((++i < noiseImages.Count) && prevent)
                                prevent = PrimitiveCheckOnConformity(noise_image, noiseImages[i]);
                            if (prevent)
                            {
                                _datafetchesImages[dimensionality][noise_image.Type].N.Add(noise_image);
                                result = _datafetchesImages[dimensionality][noise_image.Type].N.Count - 1;
                            }
                            else
                                return -1;
                        }
                    else
                    {
                        ModelImWithNoiseIm_s newType = new ModelImWithNoiseIm_s() { M = null };
                        newType.N.Add(noise_image);
                        _datafetchesImages[dimensionality].Add(noise_image.Type, newType);
                        result = 0;
                    }
                else
                {
                    Dictionary<string, ModelImWithNoiseIm_s> newGen_set = new Dictionary<string, ModelImWithNoiseIm_s>();
                    newGen_set.Add(noise_image.Type, new ModelImWithNoiseIm_s() { M = null });
                    newGen_set[noise_image.Type].N.Add(noise_image);
                    _datafetchesImages.Add(dimensionality, newGen_set);
                    result = 0;
                }
            }
            else 
                return -1;

            _size++;
            return result;
        }

        public bool RemoveType(string type)  
        {
            bool result = false;
            if (type != null)
                foreach (Dictionary<string, ModelImWithNoiseIm_s> gset in _datafetchesImages.Values)
                    if (gset.ContainsKey(type))
                    {
                        _size -= (gset[type].M == null) ? 0u : 1u;
                        _size -= (uint)gset[type].N.Count;
                        gset.Remove(type);
                        result = true;
                    }

            return result;
        }

        public bool RemoveType(byte rc, byte cc, string type)  
        {
            if (type != null)
            {
                string dimensionality = rc.ToString() + "x" + cc.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(type))
                    {
                        _size -= (_datafetchesImages[dimensionality][type].M == null) ? 0u : 1u;
                        _size -= (uint)_datafetchesImages[dimensionality][type].N.Count;
                        return _datafetchesImages[dimensionality].Remove(type);
                    }
            }

            return false;
        }

        public bool RemoveDimensionality(byte rc, byte cc)  
        {
            if (_datafetchesImages.ContainsKey(rc.ToString() + "x" + cc.ToString()))
            {
                Dictionary<string, ModelImWithNoiseIm_s> gset = _datafetchesImages[rc.ToString() + "x" + cc.ToString()];
                foreach (ModelImWithNoiseIm_s image_fromSameType in gset.Values)
                {
                    _size -= (image_fromSameType.M == null) ? 0u : 1u;
                    _size -= (uint)image_fromSameType.N.Count;
                }
                _datafetchesImages.Remove(rc.ToString() + "x" + cc.ToString());
                return true;
            }
            else 
                return false;
        }

        public void SimpleNoise(ImBinary image, double power_noise)
        {            
            for (uint i = 0; i < image.Size; i++)
                if (accidentFactor.NextDouble() < power_noise)
                    image.ReverseProp(i);
        }

        public int CreateNoiseImageFromModel(byte rc, byte cc, string type, double power_noise, TypeNoise tn)
        {
            if ((type != null) && (power_noise > 0) && (power_noise <= MAX_POWER_NOISE))
            {
                string dimensionality = rc.ToString() + "x" + cc.ToString();
                if (_datafetchesImages.ContainsKey(dimensionality))
                    if (_datafetchesImages[dimensionality].ContainsKey(type))
                    {
                        if (_datafetchesImages[dimensionality][type].M != null)
                            switch (tn)
                            {
                                case TypeNoise.Simple:
                                    ImBinary newImage = _datafetchesImages[dimensionality][type].M.Copy();
                                    SimpleNoise(newImage, power_noise);
                                    _datafetchesImages[dimensionality][type].N.Add(newImage);
                                    _size++;
                                    return _datafetchesImages[dimensionality][type].N.Count - 1;
                                default:
                                    return -1;
                            }
                    }
            }

            return -1;
        }

        private bool PrimitiveCheckOnConformity(ImBinary image1, ImBinary image2)
        {
            if ((image1 != null) && (image2 != null) && (image1.Size == image2.Size) && (image1.RowCount == image2.RowCount))
            {
                uint number_of_differences = 0;
                for (uint i = 0; i < image1.Size; i++)
                    if (image1.GetProp(i) != image2.GetProp(i))
                        number_of_differences++;

                return (((double)number_of_differences) / image1.Size < MAX_POWER_NOISE);
            }
            else
                return false;
        }
    }
}
