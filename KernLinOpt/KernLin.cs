﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KernLinOpt
{
    class KernLin
    {
        private int minValue    = 10,
                   maxValue     = 60,
                   capacity     = 100,
                   eps,
                   trying,
                   limiter,
                   size;
        private int[] initArr,
                      array,
                      arrayTmp,
                      itemsArr,
                      itemsArrTmp;

        public KernLin(int sizeInp, int tryingInp)
        {
            initArr     = new int[sizeInp];
            array       = new int[sizeInp];
            arrayTmp    = new int[sizeInp];
            size        = sizeInp;
            trying      = tryingInp;
            limiter     = (sizeInp / 3);
        }
        public void RandArr()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                initArr[i] = rnd.Next(minValue, maxValue);
            }
            initArr.CopyTo(array, 0);
        }
        private int[] calcItems(int[] arr)
        {
            int j = 0;
            List<int> items = new List<int>();
            while (j < size)
            {
                int curItem = 0;
                while ((j < size) && ((capacity - curItem) > arr[j]))
                {
                    curItem += arr[j];
                    ++j;
                }
                items.Add(curItem);
            }
            items.Sort();
            return items.ToArray<int>();
        }
        public int[] calcInitItems()
        {
            return calcItems(initArr);
        }
        public int[] calcArrItems()
        {
            return calcItems(array);
        }
        private void swapArrElements()
        {
            for (int i = 0; i < eps; ++i)
            {
                Random rnd = new Random();
                int pos1 = rnd.Next(0, size - 1);
                int pos2 = rnd.Next(0, size - 1);
                array.CopyTo(arrayTmp, 0);
                arrayTmp[pos1] = array[pos2];
                arrayTmp[pos2] = array[pos1];
            }
        }
        private bool compareResidues()
        {
            int i = 0, sizeItems = itemsArr.Length;
            while (i < sizeItems)
            {
                if (itemsArrTmp[i] < itemsArr[i])
                    return true;
                else if (itemsArrTmp[i] == itemsArr[i])
                    ++i;
                else
                    return false;
            }
            return false;
        }
        private bool ifSuccessful()
        {
            arrayTmp.CopyTo(array, 0);
            itemsArr = new int[itemsArrTmp.Length];
            itemsArrTmp.CopyTo(itemsArr, 0);
            eps *= (eps < limiter) ? 2 : 1;
            return true;
        }
        public async Task<int[]> DoKernLinAsync()
        {
            eps = 4;
            await Task.Run(() =>
            {
                itemsArr = calcItems(array);
                while (eps >= 1)
                {
                    Boolean better = false;
                    for (int i = 0; i < trying; i++)
                    {
                        if (eps >= 1)
                        {
                            swapArrElements();
                            itemsArrTmp = calcItems(arrayTmp);
                            if (itemsArr.Length > itemsArrTmp.Length)
                            {
                                better = ifSuccessful();
                                break;
                            }
                            else if ((itemsArr.Length == itemsArrTmp.Length) && compareResidues())
                            {
                                better = ifSuccessful();
                                break;
                            }
                        }
                        else break;
                    }
                    if (!better) { eps /= 2; }
                }
            });
            return itemsArr;
        }
        public async Task<bool> FirstFitDecreasing()
        {
            await Task.Run(() =>
            {
                //Сортируем по убыванию
                Array.Sort(array);
                Array.Reverse(array);

                //Ассоциативный массив листов, в которых будут хранится элементы в i-той коробке
                Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

                //Заполняем коробки
                foreach (var element in array)
                {
                    int dicSize = result.Count;
                    bool added = false;
                    //Для всех элементов ищем коробку в которую они влезут
                    for (int dicCounter = 0; dicCounter < dicSize; dicCounter++)
                    {
                        List<int> row = result[dicCounter];
                        int curItem = row.Sum();
                        if ((capacity - curItem) > element)
                        {
                            row.Add(element);
                            added = true;
                            break;
                        }
                    }
                    //Иначе добавляем еще одну коробку
                    if (!added)
                    {
                        List<int> row = new List<int>();
                        row.Add(element);
                        result.Add(dicSize, row);
                        added = true;
                    }
                }

                //Перезаполним исходный массив
                int i = 0;
                while (i < size)
                {
                    foreach (KeyValuePair<int, List<int>> row in result)
                    {
                        foreach (var element in row.Value)
                        {
                            array[i] = element;
                            ++i;
                        }
                    }
                }
                Array.Reverse(array);
            });
            return true;
        }
    }
}
