using System.Buffers.Text;

class Program
{

    //Datas to be used in training
    static int[,] Base01 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
    };

    static int[,] Base02 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 1, 0 },
    };

    static int[,] Base03 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
    };

    static int[,] Base04 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 1, 1, 1, 1, 1 },
    };

    static int[,] Base05 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 1, 0 },
    };

    static int[,] Base06 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 1, 1, 1, 1, 1 },
    };

    static int[,] Base07 =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 1, 0 },
    };

    static int[,] Base08 =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
    };

    static int[,] Base09 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 0, 0, 0 },
    };

    static int[,] Base010 =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 0, 0, 0, 0 },
    };

    static int[,] Base11 =
    {
        { 0, 1, 1, 1, 0 },
        { 1, 0, 0, 0, 1 },
        { 0, 0, 0, 1, 0 },
        { 0, 0, 1, 0, 0 },
        { 1, 1, 1, 1, 1 },

    };

    static int[,] Base12 =
    {
        { 0, 0, 1, 1, 0 },
        { 0, 1, 0, 0, 1 },
        { 0, 0, 0, 1, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 1, 1 },

    };

    static int[,] Base13 =
    {
        { 0, 1, 1, 0, 0 },
        { 1, 0, 0, 1, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 0, 0, 0 },
        { 1, 1, 1, 1, 0 },
    };

    static int[,] Base14 =
    {
        { 1, 1, 1, 1, 1 },
        { 0, 0, 0, 0, 1 },
        { 1, 1, 1, 1, 1 },
        { 1, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1 },
    };

    static int[,] Base15 =
    {
        { 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 1 },
        { 0, 1, 1, 1, 0 },
        { 1, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1 },
    };

    static int[,] Base16 =
    {
        { 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 1 },
        { 0, 1, 1, 1, 1 },
        { 1, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1 },
    };

    static int[,] Base17 =
    {
        { 0, 1, 1, 0, 0 },
        { 0, 0, 0, 1, 0 },
        { 0, 0, 1, 1, 0 },
        { 0, 1, 0, 0, 0 },
        { 0, 1, 1, 1, 0 },
    };

    static int[,] Base18 =
    {
        { 1, 1, 1, 0, 0 },
        { 0, 0, 0, 1, 0 },
        { 0, 1, 1, 1, 0 },
        { 1, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 0 },
    };

    static int[,] Base19 =
    {
        { 0, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 1 },
        { 0, 0, 1, 1, 1 },
        { 0, 1, 0, 0, 0 },
        { 0, 1, 1, 1, 1 },
    };

    static int[,] Base110 =
    {
        { 0, 1, 1, 1, 0 },
        { 1, 0, 0, 1, 1 },
        { 0, 0, 1, 1, 0 },
        { 0, 1, 1, 0, 0 },
        { 1, 1, 1, 1, 1 },

    };


    
    class Neuron
    {
        public List<Double> inputs;
        public List<double> weights;
        static Random random = new Random();

        public Neuron(int inputCount)
        {
            inputs = new List<double>(inputCount);
            weights = new List<double>(inputCount);

            // Adds every weight a value between 0 and 1
            for (int i = 0; i < inputCount; i++)
            {
                weights.Add(random.NextDouble());
            }
        }

        //Method for stting inputs according to weights count
        public void setInputs(List<double> newInputs)
        {
            if (newInputs.Count == weights.Count)
            {
                inputs = newInputs;
            }
            else
            {
                throw new ArgumentException("Input count should be same as weights count.");
            }
        }

        //Method for calculating the outputs
        public double CalculateOutputs()
        {
            double output = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                output += inputs[i] * weights[i];
            }

            return output;
        }
    }


    class NeuralNetwork
    {
        public Neuron neuron1;
        public Neuron neuron2;

        public NeuralNetwork()
        {
            neuron1 = new Neuron(25);
            neuron2 = new Neuron(25);
        }

        public void SetInputs(List<double> inputs)
        {
            neuron1.setInputs(inputs);
            neuron2.setInputs(inputs);
        }

        public double[] CalculateOutputs()
        {
            double output1 = neuron1.CalculateOutputs();
            double output2 = neuron2.CalculateOutputs();

            // An array which includes 2 outputs that can be returned
            double[] outputs = new double[2]
            {
                output1, output2
            };

            return outputs;
        }

        //Training method
        public void Train(List<double> inputs, int expected, double learningRate)
        {
            SetInputs(inputs);
            double[] value = CalculateOutputs();  

            int predicted = value[0] > value[1] ? 1 : 0;  //Calculates an output and compares them with the desired outcome

            Neuron correctNeuron;
            Neuron incorrectNeuron;

            if (predicted == expected)  //If the output isn't the desired outcome, changes the weights to find the right output
            {
                return;
            }
            else
            {
                correctNeuron = expected == 1 ? neuron1 : neuron2;

                incorrectNeuron = predicted == 1 ? neuron1 : neuron2;

            }

            for (int i = 0; i < incorrectNeuron.weights.Count; i++)
            {
                incorrectNeuron.weights[i] -= learningRate * inputs[i];
            }


            for (int i = 0; i < correctNeuron.weights.Count; i++)
            {
                correctNeuron.weights[i] += learningRate * inputs[i];
            }



        }
    }

    //Converts the matrices which are the type of the inputs to List fro the methods
    public static List<double> ConvertMatrixToList(int[,] matrix)
    {
        List<double> list = new List<double>();


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                list.Add(matrix[i, j]);
            }
        }

        return list;
    }



    public static void Main(string[] args)
    {

        // Converts all datas to lists
        List<List<double>> trainingData = new List<List<double>>()
        {
            ConvertMatrixToList(Base01),
            ConvertMatrixToList(Base02),
            ConvertMatrixToList(Base03),
            ConvertMatrixToList(Base04),
            ConvertMatrixToList(Base05),
            ConvertMatrixToList(Base06),
            ConvertMatrixToList(Base07),
            ConvertMatrixToList(Base08),
            ConvertMatrixToList(Base09),
            ConvertMatrixToList(Base010),
            ConvertMatrixToList(Base11),
            ConvertMatrixToList(Base12),
            ConvertMatrixToList(Base13),
            ConvertMatrixToList(Base14),
            ConvertMatrixToList(Base15),
            ConvertMatrixToList(Base16),
            ConvertMatrixToList(Base17),
            ConvertMatrixToList(Base18),
            ConvertMatrixToList(Base19),
            ConvertMatrixToList(Base110)
        };


        // Expected outputs for the inputs in an order
        List<int> expectedOutputs = new List<int>
        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

        NeuralNetwork neuralNetwork = new NeuralNetwork();
        double learningRate = 0.03;

        //Training loop with 0.03 Learning Rate and 40 epoch
        for (int epoch = 0; epoch < 40; epoch++)
        {
            for (int i = 0; i < trainingData.Count; i++)
            {
                List<double> inputs = trainingData[i];
                int expected = expectedOutputs[i];

                neuralNetwork.Train(inputs, expected, learningRate);
            }
        }

        int correctPredictions = 0;

        //The loop which only looks for the correct predictions
        for (int i = 0; i < trainingData.Count; i++)
        {
            List<double> inputs = trainingData[i];
            int expected = expectedOutputs[i];

            neuralNetwork.SetInputs(inputs);
            double[] outputs = neuralNetwork.CalculateOutputs();

            int predicted = outputs[0] > outputs[1] ? 1 : 2;

            if (predicted == expected)
            {
                correctPredictions++;
            }

        }

        //Prints the correctness rate
        double correctness = correctPredictions / trainingData.Count * 100;
        Console.WriteLine($" The Correctness Rate is %{correctness:F2}");


        //New Inputs which program didnt see for tests
        int[,] newInput1 = {
            {0, 0, 1, 0, 0 },
            {0, 1, 1, 0, 0 },
            {1, 0, 1, 0, 0 },
            {0, 0, 1, 0, 0 },
            {0, 0, 1, 0, 0 },
        };

        int[,] newInput2 =
        {
            {0, 0, 1, 0, 0 },
            {0, 1, 1, 0, 0 },
            {1, 0, 1, 0, 0 },
            {0, 0, 1, 0, 0 },
            {0, 1, 1, 1, 0 },
        };

        int[,] newInput3 =
        {
            {0, 0, 1, 0, 0 },
            {0, 1, 1, 0, 0 },
            {1, 0, 1, 0, 0 },
            {0, 0, 1, 0, 0 },
            {1, 1, 1, 1, 1 },
        };

        int[,] newInput4 =
        {
            {0, 1, 1, 1, 0 },
            {0, 0, 0, 1, 0 },
            {0, 1, 1, 1, 0 },
            {0, 1, 0, 0, 0 },
            {0, 1, 1, 1, 0 },
        };

        int[,] newInput5 =
        {
            {0, 1, 1, 1, 0 },
            {0, 0, 0, 1, 0 },
            {0, 0, 1, 1, 0 },
            {0, 1, 0, 0, 0 },
            {0, 1, 1, 1, 0 },
        };

        int[,] newInput6 =
        {
            { 0, 1, 1, 1, 0 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 1, 1, 1, 1 },
        };


        List<List<double>> controlData = new List<List<double>>()
        {
            ConvertMatrixToList(newInput1),
            ConvertMatrixToList(newInput2),
            ConvertMatrixToList(newInput3),
            ConvertMatrixToList(newInput4),
            ConvertMatrixToList(newInput5),
            ConvertMatrixToList(newInput6),
        };

        //A method for printing matrices
        static void PrintMatrix(List<double> matrix)
        {

            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.Count; i++)
            {
                Console.Write($"{(int)Math.Round(matrix[i])} ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    
        //The final loop which looks for the new inputs and prints its predictions with the matrices.
        for (int i = 0; i < controlData.Count; i++)
        {
            neuralNetwork.SetInputs(controlData[i]);
            double[] outputs = neuralNetwork.CalculateOutputs();
            int predictedClass = Array.IndexOf(outputs, outputs.Max());

            PrintMatrix(controlData[i]);
            Console.WriteLine($"Predicted: {predictedClass + 1}");
            Console.WriteLine(new string('-', 20));
            
        }
    }
}

